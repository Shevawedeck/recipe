using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal class BizMeasurementType: BizObject<BizMeasurementType>
    {
        private int _measurementtypeid;
        private string _measurementtypename = "";
        public int MeasurementTypeId
        {
            get { return _measurementtypeid; }
            set
            {
                if (_measurementtypeid != value)
                {
                    _measurementtypeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string MeasurementTypeName
        {
            get { return _measurementtypename; }
            set
            {
                if (_measurementtypename != value)
                {
                    _measurementtypename = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
