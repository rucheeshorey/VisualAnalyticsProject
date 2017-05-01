using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using VisualAnalyticsProject;
using System.Reflection;
using System.Web.UI.DataVisualization.Charting;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CSVReader reader = new CSVReader( File.OpenRead( Server.MapPath( "~/App_Data/menu.csv" ) ) );
        String[] headers = reader.GetCSVLine();
        String[] menuItem;
        while ( ( menuItem = reader.GetCSVLine() ) != null )
        {
            //Anchor
            HtmlGenericControl anchor = new HtmlGenericControl( "div" );
            anchor.Attributes[ "class" ] = "col-xs-3 menuitem";
            anchor.ID = "item" + menuItem[0] + "anchor";
            anchor.ClientIDMode = ClientIDMode.Static;
            anchor.InnerText = menuItem[ 2 ];

            //Dialog
            HtmlGenericControl dialog = new HtmlGenericControl( "div" );
            dialog.ID = "item" + menuItem[ 0 ] + "dialog";
            dialog.ClientIDMode = ClientIDMode.Static;
            dialog.Attributes["title"] = menuItem[ 2 ] + " Nutritional Information";
            dialog.InnerHtml = menuItem[2];
            anchor.Controls.Add( dialog );

            //JS
            HtmlGenericControl js = new HtmlGenericControl("script");
            js.InnerHtml = "$(function() { $(\"#" + dialog.ID + "\").dialog({ autoOpen: false, width: 'auto', height: 'auto' }); $(\"#" + anchor.ID + "\").click(function() { $(\"#" + dialog.ID + "\").dialog(\"open\"); }); }); ";
            Page.Header.Controls.Add(js);

            //TODO: Chart

            if ( menuItem[ 1 ].Equals( "Breakfast" ) )
            {
                breakfastsubsection.Controls.Add( anchor );
                breakfastsubsection.ClientIDMode = ClientIDMode.Static;
            } else if ( menuItem[ 1 ].Equals( "Burgers" ) )
            {
                burgersubsection.Controls.Add( anchor );
                burgersubsection.ClientIDMode = ClientIDMode.Static;
            }
            else if ( menuItem[ 1 ].Equals( "Drinks" ) )
            {
                drinksubsection.Controls.Add( anchor );
                drinksubsection.ClientIDMode = ClientIDMode.Static;
            }
            else if ( menuItem[ 1 ].Equals( "Salads" ) )
            {
                saladsubsection.Controls.Add( anchor );
                saladsubsection.ClientIDMode = ClientIDMode.Static;
            }
            else if ( menuItem[ 1 ].Equals( "Sides" ) )
            {
                sidesubsection.Controls.Add( anchor );
                sidesubsection.ClientIDMode = ClientIDMode.Static;
            }
            else if ( menuItem[ 1 ].Equals( "Desserts" ) )
            {
                dessertsubsection.Controls.Add( anchor );
                dessertsubsection.ClientIDMode = ClientIDMode.Static;
            }
        }
    }
}