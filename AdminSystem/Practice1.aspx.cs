﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Practice1 : System.Web.UI.Page
{
    DataTable dt;
    Int64 totalprice;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = new DataTable();
            dt.Columns.Add("sno");
            dt.Columns.Add("productname");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");
            dt.Columns.Add("total");
            Session["data"] = dt;
            TextBox1.Text = "1";
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dt = (DataTable)Session["data"];
        DataRow dr;
        dr = dt.NewRow();
        if (dt.Rows.Count > 0)
        {
            dr["sno"] = TextBox1.Text;
            dr["productname"] = TextBox2.Text;
            dr["quantity"] = TextBox3.Text;
            dr["price"] = TextBox4.Text;
            totalprice = Convert.ToInt64(TextBox3.Text) * Convert.ToInt64(TextBox4.Text);
            dr["total"] = totalprice.ToString();
        }
        else
        {
            dr["sno"] = TextBox1.Text;
            dr["productname"] = TextBox2.Text;
            dr["quantity"] = TextBox3.Text;
            dr["price"] = TextBox4.Text;
            totalprice = Convert.ToInt64(TextBox3.Text) * Convert.ToInt64(TextBox4.Text);
            dr["total"] = totalprice.ToString();
        }
        dt.Rows.Add(dr);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        Session["buyitems"] = dt;
        TextBox1.Text = (dt.Rows.Count + 1).ToString();
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        calculateSum();

    }

    private void calculateSum()
    {
        Int32 grandtotal = 0;
        foreach (GridViewRow row in GridView1.Rows)
        {

            grandtotal = grandtotal + Convert.ToInt32(row.Cells[4].Text);
        }
        GridView1.FooterRow.Cells[3].Text = "Grand Total";
        GridView1.FooterRow.Cells[4].Text = grandtotal.ToString();
        Label3.Text = "Price(in Words) " + ConvertNumbertoWords(grandtotal);
    }
    public static string ConvertNumbertoWords(int number)
    {
        if (number == 0)
            return "ZERO";
        if (number < 0)
            return "minus " + ConvertNumbertoWords(Math.Abs(number));
        string words = "";
        if ((number / 100000) > 0)
        {
            words += ConvertNumbertoWords(number / 100000) + " Lacs ";
            number %= 100000;
        }
        if ((number / 1000) > 0)
        {
            words += ConvertNumbertoWords(number / 1000) + " Thousand ";
            number %= 1000;
        }
        if ((number / 100) > 0)
        {
            words += ConvertNumbertoWords(number / 100) + " Hundred ";
            number %= 100;
        }
        if (number > 0)
        {
            if (words != "")
                words += "AND ";
            var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " " + unitsMap[number % 10];
            }
        }
        return words;
    }
}