using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MusicDownLoad2._0
{
    public partial class MainForm : Form
    {
        #region 全局变量定义

        // 查询主线程
        private Thread mainThread = null;
        // 主线程委托
        private delegate void mainDelegate();
        // 下载链接
        private string downLoadUrl = string.Empty;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        // 窗体初始化方法
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        // 点击数据单元格事件(预览图片)
        private void dgv_Songs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 图片预览

            string cellValue = dgv_Songs[e.ColumnIndex, e.RowIndex].Value.ToString(); // 点击单元格上的值
            if (cellValue.IndexOf("http://") >= 0) // 如果带有该字符串则为图片链接, 进行预览操作
            {
                try
                {
                    #region 组件状态修改

                    btn_Query.Enabled = !btn_Query.Enabled; // 检索按钮禁用
                    txt_SongOrSinger.Enabled = !txt_SongOrSinger.Enabled; // 检索文本框禁用
                    SetProgressValue(30);
                    lbl_QueryProgress.Text = "图片加载中, 请稍后..."; // 对应进度文本显示信息修改
                    lbl_QueryProgress.ForeColor = Color.Red; // 文本颜色设置

                    #endregion

                    SetProgressValue(50);
                    Image image = Image.FromStream(GetWebResponse(cellValue).GetResponseStream());
                    SetProgressValue(70);

                    ShowImage showImage = new ShowImage(image);
                    showImage.StartPosition = FormStartPosition.CenterScreen;

                    showImage.Show();
                }
                catch (Exception ex)
                {
                    // 出现错误
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    #region 组件状态修改

                    btn_Query.Enabled = !btn_Query.Enabled; // 检索按钮禁用
                    txt_SongOrSinger.Enabled = !txt_SongOrSinger.Enabled; // 检索文本框禁用
                    SetProgressValue(100);
                    lbl_QueryProgress.Text = "图片加载完毕!"; // 对应进度文本显示信息修改
                    lbl_QueryProgress.ForeColor = Color.Green; // 文本颜色设置

                    #endregion
                }
            }

            #endregion
        }

        // 右键选中行
        private void dgv_Songs_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            (sender as DataGridView).CurrentRow.Selected = false;

            (sender as DataGridView).Rows[e.RowIndex].Selected = true;
        }

        // 单击检索按钮, 开始检索
        private void btn_Query_Click(object sender, EventArgs e)
        {
            #region 组件状态修改

            btn_Query.Enabled = !btn_Query.Enabled; // 检索按钮禁用
            txt_SongOrSinger.Enabled = !txt_SongOrSinger.Enabled; // 检索文本框禁用
            SetProgressValue(20);
            lbl_QueryProgress.Text = "正在检索, 请稍后..."; // 对应进度文本显示信息修改
            lbl_QueryProgress.ForeColor = Color.Red; // 文本颜色设置

            #endregion

            // 线程所属方法初始化
            mainThread = new Thread(Query);
            // 启动查询线程
            mainThread.Start();
        }

        // 在搜索栏敲击回车查询事件
        private void txt_SongOrSinger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                // 触发检索事件
                btn_Query.PerformClick();
            }
        }

        // 单击下载按钮触发事件
        private void menuBtn_DownLoad_Click(object sender, EventArgs e)
        {
            DownLoad();
        }

        // 复制下载链接
        private void menuBtn_CopyDownLoadUrl_Click(object sender, EventArgs e)
        {
            GetDownLoadUrl(); // 获取下载链接
            Clipboard.SetDataObject(downLoadUrl);
            if (dgv_Songs.SelectedRows.Count > 0)
            {
                lbl_QueryProgress.Text = "复制成功!";
            }
        }

        // 打开下载链接文件夹
        private void lbl_saveFilePath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lbl_saveFilePath.Text);
        }

        #region 歌曲查询、下载等方法(主要方法)

        /// <summary>
        /// 主要查询歌曲方法
        /// </summary>
        public void Query()
        {
            try
            {
                // 访问类初始化
                string requestUriString = $"http://yueyue.kuwo.cn/api/search/music/list?pn=0&rn=101&keyword={ txt_SongOrSinger.Text }&uid=-1&token=";
                SetProgressValue(40);
                WebResponse webResponse = GetWebResponse(requestUriString);
                Stream stream = webResponse.GetResponseStream();
                Stream resultStream = stream;
                SetProgressValue(55);

                if (webResponse.Headers["Content-Encoding"].IndexOf("gzip") >= 0)
                {
                    resultStream = new GZipStream(stream, CompressionMode.Decompress);
                }
                else
                {
                    resultStream = new DeflateStream(stream, CompressionMode.Decompress);
                }

                SetProgressValue(68);

                if (resultStream != null)
                {
                    using (StreamReader streamReader = new StreamReader(resultStream, Encoding.UTF8))
                    {
                        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                        string responseStr = streamReader.ReadToEnd();
                        JObject result = (JObject)JsonConvert.DeserializeObject(responseStr);
                        string code = Convert.ToString(result["code"]);
                        JToken data = result["data"];
                        List<Music> musics = data["resultList"].ToObject<List<Music>>();
                        if (dgv_Songs.InvokeRequired)
                        {
                            mainDelegate main = new mainDelegate(() =>
                            {
                                dgv_Songs.DataSource = musics;
                                pro_QueryProgress.Value = 90; // 进度条值设置
                            });
                            Invoke(main);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // 输出错误信息
                MessageBox.Show(e.Message);
            }
            finally
            {
                #region 组件状态修改

                mainDelegate main = new mainDelegate(() =>
                {
                    btn_Query.Enabled = !btn_Query.Enabled; // 检索按钮禁用
                    txt_SongOrSinger.Enabled = !txt_SongOrSinger.Enabled; // 检索文本框禁用
                    pro_QueryProgress.Value = 100; // 进度条值设置
                    lbl_QueryProgress.Text = "检索完毕!"; // 对应进度文本显示信息修改
                    lbl_QueryProgress.ForeColor = Color.Green; // 文本颜色设置
                });
                Invoke(main);

                #endregion

                // 线程终止
                mainThread.Abort();
            }
        }

        /// <summary>
        /// 歌曲下载方法
        /// </summary>
        public void DownLoad()
        {
            try
            {
                // 获取数据选中项
                if (dgv_Songs.SelectedRows.Count > 0)
                {
                    saveFileDialog_Music.Filter = "MP3文件|*.MP3";
                    saveFileDialog_Music.FileName = Convert.ToString(dgv_Songs.SelectedRows[0].Cells[1].Value) + ".mp3";
                    if (saveFileDialog_Music.ShowDialog() == DialogResult.OK)
                    {
                        GetDownLoadUrl(); // 先获取最新的下载链接
                        lbl_QueryProgress.Text = "正在下载, 请稍后...";
                        lbl_QueryProgress.ForeColor = Color.Red;
                        SetProgressValue(12);

                        string filePath = saveFileDialog_Music.FileName; // 保存文件路径
                        WebResponse webResponse = GetWebResponse(downLoadUrl);
                        Stream stream = webResponse.GetResponseStream();

                        SetProgressValue(40 + new Random().Next(1, 20));

                        // 保存数据流
                        using (FileStream fileStream = File.Create(filePath))
                        {
                            SetProgressValue(60 + new Random().Next(1, 20));
                            lbl_QueryProgress.Text = "正在保存文件...";

                            stream.CopyTo(fileStream);

                            SetProgressValue(100);
                            lbl_QueryProgress.Text = "下载完毕, 保存成功!";
                            lbl_saveFilePath.Text = filePath;
                            lbl_QueryProgress.ForeColor = Color.Green;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先选中要下载的歌曲!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取歌曲下载链接
        /// </summary>
        public void GetDownLoadUrl()
        {
            #region 获取下载链接

            try
            {
                if (dgv_Songs.SelectedRows.Count > 0)
                {
                    lbl_QueryProgress.Text = "正在获取下载链接...";
                    lbl_QueryProgress.ForeColor = Color.Red;
                    SetProgressValue(25);
                    // 遍历选中歌曲
                    foreach (DataGridViewRow row in dgv_Songs.SelectedRows)
                    {
                        string musicRid = row.Cells["musicRid"].Value.ToString();
                        downLoadUrl = "https://yueyue.kuwo.cn/api/service/music/audioUrl/" + musicRid.Split('_')[1]; // 获取音频请求地址
                        WebResponse webResponse = GetWebResponse(downLoadUrl);
                        Stream stream = webResponse.GetResponseStream();
                        Stream resultStream = stream;
                        SetProgressValue(70);

                        // 判断相应数据类型解压并创建对应数据流
                        if (webResponse.Headers["Content-Encoding"].IndexOf("gzip") >= 0)
                        {
                            resultStream = new GZipStream(stream, CompressionMode.Decompress);
                        }
                        else
                        {
                            resultStream = new DeflateStream(stream, CompressionMode.Decompress);
                        }
                        if (resultStream != null)
                        {
                            using (StreamReader streamReader = new StreamReader(resultStream, Encoding.UTF8))
                            {
                                string responseStr = streamReader.ReadToEnd();
                                JObject result = (JObject)JsonConvert.DeserializeObject(responseStr);
                                string data = Convert.ToString(result["data"]).Replace("\n", ""); // 接受返回数据
                                downLoadUrl = Regex.Match(data, "[a-zA-z]+://[^\\s]*").Value.Replace("\"", ""); // 匹配MP3下载链接
                                SetProgressValue(100);
                                lbl_QueryProgress.Text = "获取下载链接成功!";
                                lbl_QueryProgress.ForeColor = Color.Green;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_QueryProgress.Text = "下载链接获取失败, " + ex.Message + "!";
                SetProgressValue(0);
            }

            #endregion
        }

        #endregion

        #region 公用方法

        /// <summary>
        /// 设置进度条的值
        /// </summary>
        /// <param name="value">进度条值</param>
        public void SetProgressValue(int value)
        {
            mainDelegate main = new mainDelegate(() =>
            {
                pro_QueryProgress.Value = value; // 进度条值设置
            });
            Invoke(main);
        }

        /// <summary>
        /// 获取请求Url响应WebResponse对象
        /// </summary>
        /// <param name="url">请求url</param>
        /// <param name="contentEncoding">相应内容编码(gzip、deflate等)</param>
        /// <returns>返回请求后的响应数据流</returns>
        public WebResponse GetWebResponse(string url, string contentEncoding = "gzip, deflate")
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Mobile Safari/537.36";
            httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, contentEncoding); // 压缩格式接受数据
            httpWebRequest.Timeout = 10000; // 10秒
            httpWebRequest.KeepAlive = true; // 建立持久性链接
            httpWebRequest.Accept = "*/*";

            WebResponse webResponse = httpWebRequest.GetResponse(); // 获取请求数据

            return webResponse;
        }

        #endregion
    }

    /// <summary>
    /// 接受json数据的model
    /// </summary>
    public class Music
    {
        /// <summary>
        /// 歌曲Id 主要用来下载(Id中有字符串, 请注意)
        /// </summary>
        public string musicRid { get; set; }

        /// <summary>
        /// 歌曲名称
        /// </summary>
        public string songName { get; set; }

        /// <summary>
        /// 歌手名称
        /// </summary>
        public string artist { get; set; }

        /// <summary>
        /// 歌曲图片
        /// </summary>
        public string albumPic { get; set; }

        /// <summary>
        /// 专辑图片
        /// </summary>
        public string albumPic120 { get; set; }
    }
}
