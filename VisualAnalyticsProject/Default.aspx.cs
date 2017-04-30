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
            HtmlGenericControl anchor = new HtmlGenericControl( "a" );
            anchor.Attributes["rel"] = "modal:open";
            anchor.Attributes["href"] = "#item" + menuItem[ 0 ] + "modal";
            anchor.Attributes[ "class" ] = "col-xs-3 menuitem";
            anchor.InnerText = menuItem[ 2 ];

            //Modal
            HtmlGenericControl modal = new HtmlGenericControl( "div" );
            modal.Attributes[ "class" ] = "menuitemmodal";
            modal.Style.Add( "display", "none" );
            modal.ID = "item" + menuItem[ 0 ] + "modal";
            modal.ClientIDMode = ClientIDMode.Static;

            //TODO: Chart
            


            anchor.Controls.Add( modal );

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