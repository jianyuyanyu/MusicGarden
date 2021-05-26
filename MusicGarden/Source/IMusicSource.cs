using System.Collections.Generic;
using System;
using MusicGarden.Http;

namespace MusicGarden.Source
{
    /// <summary>
    /// 定义MusicSource接口
    /// </summary>
    public interface IMusicSource
    {
        string Name { get; }
        List<Song> SearchSongs(string keyword, int page, int pageSize); //参数分别是关键词、页数、每页数量
        string getDownloadUrl(Song song);
        
    }
}