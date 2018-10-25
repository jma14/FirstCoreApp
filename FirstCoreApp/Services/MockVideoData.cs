using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Models;

namespace FirstCoreApp.Services
{
    public class MockVideoData : IVideoData
    {
        private List<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "Shrek" },
                new Video { Id = 2, Title = "ABC"},
                new Video { Id = 3, Title = "DEF"}
            };
        }
        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}
