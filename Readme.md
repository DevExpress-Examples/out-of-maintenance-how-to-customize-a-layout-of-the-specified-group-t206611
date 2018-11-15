<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx.cs](./CS/Dashboard_UpdateGroupLayout/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_UpdateGroupLayout/WebForm1.aspx.vb))
<!-- default file list end -->
# How to customize a layout of the specified group


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to change a layout of the specified group in code.<br><br>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> loads an existing dashboard with the predefined layout from an <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15405">XML file</a>. The bottom <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17586">group</a> contains three dashboard items that are placed horizontally side-by-side.<br>
<p>The following steps are performed to customize a group layout:</p>
<p>- Three layout items corresponding to existing dashboard items are obtained using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_FindRecursivetopic">FindRecursive</a> method. The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutNode_Weighttopic">Weight</a> property specifies the layout item size.<br>- Child items contained within the bottom group are removed using the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessNotifyingCollection~T~_RemoveRangetopic">RemoveRange</a> method.<br>- A new layout group is created to display the Combo Box and List Box <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17659">filter elements</a>. The <em>orientation</em> parameter specifies the orientation of layout items within this group.<br>- A newly created group and layout item displaying the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument14719">Chart</a> dashboard item are added to the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_ChildNodestopic">ChildNodes</a> collection.</p>

<br/>


