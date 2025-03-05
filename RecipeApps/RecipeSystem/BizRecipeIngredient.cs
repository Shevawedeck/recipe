using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class BizRecipeIngredient: BizObject<BizRecipeIngredient>
    {
        private int _recipeingredientid;
        private int _recipeid;
        private int _ingredientid;
        private string _ingredientname = "";
        private int _measurementtypeid;
        private int _amount;
        private int _sequencenum;

        public List<BizRecipeIngredient>LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public int RecipeIngredientId
        {
            get { return _recipeingredientid;}
            set
            {
                if (_recipeingredientid != value)
                {
                    _recipeingredientid = value;
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
        public int IngredientId
        {
            get { return _ingredientid; }
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string IngredientName
        {
            get { return _ingredientname; }
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }
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
        public int Amount
        {
            get { return _amount; }
            set
            {
                if(_amount != value)
                {
                    _amount = value;
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
                    _amount = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
