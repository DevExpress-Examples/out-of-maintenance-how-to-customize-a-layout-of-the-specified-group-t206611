using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;

namespace Dashboard_UpdateGroupLayout {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_DashboardLoaded(object sender, 
            DashboardLoadedWebEventArgs e) {
            Dashboard dashboard = e.Dashboard;
            DashboardLayoutGroup root = dashboard.LayoutRoot;
            DashboardLayoutGroup bottomLayoutGroup = root.FindRecursive(e.Dashboard.Groups[1]);

            DashboardItem comboBox = (ComboBoxDashboardItem)dashboard.Items["comboBoxDashboardItem1"];
            DashboardItem listBox = (ListBoxDashboardItem)dashboard.Items["listBoxDashboardItem1"];
            DashboardItem chart = (ChartDashboardItem)dashboard.Items["chartDashboardItem2"];

            DashboardLayoutItem comboBoxLayoutItem = root.FindRecursive(comboBox); 
            comboBoxLayoutItem.Weight = 10;
            DashboardLayoutItem listBoxLayoutItem = root.FindRecursive(listBox); 
            listBoxLayoutItem.Weight = 90;
            DashboardLayoutItem chartLayoutItem = root.FindRecursive(chart); 
            chartLayoutItem.Weight = 76;

            bottomLayoutGroup.ChildNodes.RemoveRange(comboBoxLayoutItem, 
                listBoxLayoutItem, chartLayoutItem);
            DashboardLayoutGroup childGroup1 = new DashboardLayoutGroup(
                DashboardLayoutGroupOrientation.Vertical, 24, 
                comboBoxLayoutItem, 
                listBoxLayoutItem);
            bottomLayoutGroup.ChildNodes.AddRange(childGroup1, chartLayoutItem);            
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName == "WebsiteStatisticsDataConnection") {
                XmlFileConnectionParameters parameters =
                    (XmlFileConnectionParameters)e.ConnectionParameters;
                string databasePath = Server.MapPath("App_Data/WebsiteStatisticsData.xml");
                parameters.FileName = databasePath;
            }
        }
    }
}