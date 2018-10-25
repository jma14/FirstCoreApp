using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Models;

namespace FirstCoreApp.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
    }
}
