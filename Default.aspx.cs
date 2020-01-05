using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.AutoPostBack = true;
        CheckBox1.AutoPostBack = true;
        CheckBox2.AutoPostBack = true;
        CheckBox3.AutoPostBack = true;
        TextBox1.Text = "100000";
        
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
            TextBox1.Text = (int.Parse(TextBox1.Text) + 2000).ToString();
        else
            TextBox1.Text = (int.Parse(TextBox1.Text) + 2000).ToString();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked)
            TextBox1.Text = (int.Parse(TextBox1.Text) + 2000).ToString();
        else
            TextBox1.Text = (int.Parse(TextBox1.Text) + 2000).ToString();
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox3.Checked)
            TextBox1.Text = (int.Parse(TextBox1.Text) + 2000).ToString();
        else
            TextBox1.Text = (int.Parse(TextBox1.Text) + 2000).ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(TextBox1.Text) > 100000)
            Label1.Text = "%5 indirimli fiyatı" + (int.Parse(TextBox1.Text) * 0.95).ToString();
        if (Convert.ToInt32(TextBox1.Text) < 100000)
            Label1.Text = "%3 indirimli fiyatı" + (int.Parse(TextBox1.Text) * 0.97).ToString();
    }
}