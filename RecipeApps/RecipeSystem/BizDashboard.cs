﻿
namespace RecipeSystem
{
    public class bizDashboard : BizObject<bizDashboard>
    {
        private string _dashboardType = "";
        private string _dashboardText = "";

        public string DashboardType
        {
            get { return _dashboardType; }
            set
            {
                if (_dashboardType != value)
                {
                    _dashboardType = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string DashboardText
        {
            get { return _dashboardText; }
            set
            {
                if (_dashboardText != value)
                {
                    _dashboardText = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
