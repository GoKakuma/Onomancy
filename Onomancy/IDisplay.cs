using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 画面表示インタフェース
    /// </summary>
    public interface IDisplay
    {
        void Display(List<NameBase> names);
    }
}
