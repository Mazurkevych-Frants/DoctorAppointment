using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3
{
    public interface Interface
    {
        public interface IOutput
        {
            void Show();
            void Show(string info);
        }

        public interface IMath
        {
            int Max();
            int Min();
            float Avg();
            bool Search(int valueToSearch);
        }

        public interface ISort
        {
            void SortAsc();
            void SortDesc();
            void SortByParam(bool isAsc);
        }
    }
}
