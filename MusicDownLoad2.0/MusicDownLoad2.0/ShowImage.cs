﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDownLoad2._0
{
    public partial class ShowImage : Form
    {
        public ShowImage(Image image)
        {
            InitializeComponent();
            this.image.Image = image;
        }
    }
}
