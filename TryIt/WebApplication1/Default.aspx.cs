﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;




namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            currencyS.Service1Client sv = new currencyS.Service1Client();
            string str = sv.currency(this.TextBox1.Text);

            this.Label1.Text = str;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            hotelS.Service1Client sv = new hotelS.Service1Client();
            string[] re = new string[10];
            re = sv.hotel(TextBox2.Text);
            for(int i = 0;i < 10; i++)
            {
                this.Label2.Text += "\n" + re[i];
            }

   
        }

        }
    }
