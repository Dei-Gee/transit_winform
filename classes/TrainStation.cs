using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transit_Winform.classes
{
    class TrainStation
    {
        private string _name;
        private string _line;
        private bool _is_changeover;


        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public string Line
        {
            get
            {
                return this._line;
            }

            set
            {
                this._line = value;
            }
        }

        public bool IsChangeOver
        {
            get
            {
                return this._is_changeover;
            }

            set
            {
                this._is_changeover = value;
            }
        }
    }
}
