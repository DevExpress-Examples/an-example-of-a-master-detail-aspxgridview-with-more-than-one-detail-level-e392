﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DevExpress.Web.ASPxGridView;

namespace TwoDetailGrids {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void productsGrid_DataSelect(object sender, EventArgs e) {
            Session["SupplierID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }
        protected void orderItemsGrid_BeforePerformDataSelect(object sender, EventArgs e) {
            Session["ProductID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }
    }
}
