﻿namespace Bookie.Web.Home
{
    using Bookie.Web.Models;
    using System;
    using System.Linq;
    using System.Web.UI;

    public partial class _Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var categories = this.Data.Categories.All().Select(c=> c.Name);
            this.BaiHui.Text = String.Join(", ", categories);

        }
    }
}