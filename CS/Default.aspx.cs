using System;
partial class TestPage : System.Web.UI.Page {
    override protected void OnInit(EventArgs e) {
        base.OnInit(e);
        ASPxComboBox1.DataBound += ASPxComboBox1_DataBound;
        ASPxComboBox2.DataBound += new EventHandler(ASPxComboBox2_DataBound);
        DropDownList1.DataBound += new EventHandler(DropDownList1_DataBound);
    }
    void ASPxComboBox2_DataBound(object sender, EventArgs e) {
        //By value
        ASPxComboBox2.SelectedItem = ASPxComboBox2.Items.FindByValue("17");
        //OR by display text
        ASPxComboBox2.SelectedItem = ASPxComboBox2.Items.FindByText("Chai");
    }
    void DropDownList1_DataBound(object sender, EventArgs e) {
        string someText = "213-46-8915"; // the ID for Chris
        DropDownList1.SelectedValue = someText;
    }
    protected void ASPxComboBox1_DataBound(object sender, System.EventArgs e) {
        //By value
        int iterator = 0;
        for (iterator = 0; iterator < ASPxComboBox1.Items.Count; iterator++) {
            DevExpress.Web.ListEditItem currentItem = ASPxComboBox1.Items[iterator];
            if (currentItem.Value.ToString() == "213-46-8915") {
                ASPxComboBox1.SelectedItem = currentItem;
            }
        }
        //OR by display text
        //ASPxComboBox1.SelectedIndex = ASPxComboBox1.Items.IndexOfText("Chris");
    }
}