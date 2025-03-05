using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class BizDirection: BizObject<BizDirection>
    {
        private int _directionid;
        private int _recipeid;
        private int _sequencenum;
        private string _directiondesc = "";

        public List<BizDirection> LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public int DirectionId
        {
            get { return _directionid; }
            set
            {
                if (_directionid != value)
                {
                    _directionid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int SequenceNum
        {
            get { return _sequencenum; }
            set
            {
                if (_sequencenum != value)
                {
                    _sequencenum = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string DirectionDesc
        {
            get { return _directiondesc; }
            set
            {
                if (_directiondesc != value)
                {
                    _directiondesc = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
