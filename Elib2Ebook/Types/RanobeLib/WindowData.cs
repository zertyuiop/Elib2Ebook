using System.Text.Json.Serialization;

namespace Elib2Ebook.Types.RanobeLib; 

public class WindowData {
    [JsonPropertyName("chapters")] 
    public Chapters Chapters { get; set; }
}