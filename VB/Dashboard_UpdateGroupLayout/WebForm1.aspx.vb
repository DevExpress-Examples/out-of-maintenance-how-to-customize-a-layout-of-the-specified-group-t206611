Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon

Namespace Dashboard_UpdateGroupLayout
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_DashboardLoaded(ByVal sender As Object, _
                                           ByVal e As DashboardLoadedWebEventArgs)
            Dim dashboard As Dashboard = e.Dashboard
            Dim root As DashboardLayoutGroup = dashboard.LayoutRoot
            Dim bottomLayoutGroup As DashboardLayoutGroup = root.FindRecursive(e.Dashboard.Groups(1))

            Dim comboBox As DashboardItem = CType(dashboard.Items("comboBoxDashboardItem1"),  _
                ComboBoxDashboardItem)
            Dim listBox As DashboardItem = CType(dashboard.Items("listBoxDashboardItem1"),  _
                ListBoxDashboardItem)
            Dim chart As DashboardItem = CType(dashboard.Items("chartDashboardItem2"),  _
                ChartDashboardItem)

            Dim comboBoxLayoutItem As DashboardLayoutItem = root.FindRecursive(comboBox)
            comboBoxLayoutItem.Weight = 10
            Dim listBoxLayoutItem As DashboardLayoutItem = root.FindRecursive(listBox)
            listBoxLayoutItem.Weight = 90
            Dim chartLayoutItem As DashboardLayoutItem = root.FindRecursive(chart)
            chartLayoutItem.Weight = 76

            bottomLayoutGroup.ChildNodes.RemoveRange(comboBoxLayoutItem, _
                                                     listBoxLayoutItem, _
                                                     chartLayoutItem)
            Dim childGroup1 As New DashboardLayoutGroup(DashboardLayoutGroupOrientation.Vertical, 24, _
                                                        comboBoxLayoutItem, listBoxLayoutItem)
            bottomLayoutGroup.ChildNodes.AddRange(childGroup1, chartLayoutItem)
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                           ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.ConnectionName = "WebsiteStatisticsDataConnection" Then
                Dim parameters As XmlFileConnectionParameters = CType(e.ConnectionParameters,  _
                    XmlFileConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/WebsiteStatisticsData.xml")
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace