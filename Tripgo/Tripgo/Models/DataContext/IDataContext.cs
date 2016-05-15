using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripgo.Models.DataContext
{
   public interface Model
    {
          int insert();
          int update();
          int delete();
          object select();
        
    }
}
