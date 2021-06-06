/* http://www.zkea.net/ 
 * Copyright 2017 ZKEASOFT 
 * 深圳市纸壳软件科技有限公司
 * http://www.zkea.net/licenses */


namespace ZKEACMS.Widget
{
    public class DesignWidgetViewModel : WidgetViewModelPart
    {
        public DesignWidgetViewModel(WidgetViewModelPart widgetPart, string pageId) 
            : base(widgetPart.Widget, widgetPart.ViewModel)
        {
            PageID = pageId;
        }
        public string PageID { get; set; }
    }
}