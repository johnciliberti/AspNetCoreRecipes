using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Recipe04.Models
{
    public class TagCloud
    {
        public int MaxSize { get; set; }
        public int MinSize { get; set; }
        public string BaseLinkClassName { get; set; }
        public string ContainerClassName { get; set; }

        private List<TagCloudItem> _Items { get; set; }
        private int minRank = 1;
        private int maxRank = 1;

        public ReadOnlyCollection<TagCloudItem> Items
        {
            get
            {
                if (_Items != null)
                {
                    var readOnlyCollection = new ReadOnlyCollection<TagCloudItem>(_Items);
                    return readOnlyCollection;
                }
                return null;
            }
        }

        public void AddItem(TagCloudItem item)
        {
            _Items.Add(item);
            minRank = _Items.Min(x => x.Weight);
            maxRank = _Items.Max(x => x.Weight);
        }

        public TagCloud()
        {
            MaxSize = 10;
            MinSize = 1;
            BaseLinkClassName = "linkLevel-";
            ContainerClassName = "tagcloud";
            _Items = new List<TagCloudItem>();
        }

        public string GetLinkItemClassName(TagCloudItem item)
        {
            int itemCount = Items.Count;
            if (maxRank == MaxSize && minRank == MinSize)
            {
                return string.Concat(BaseLinkClassName, item.Weight);
            }

            int normalizedRank = 1 + (item.Weight - minRank) *
               (MaxSize - 1) / (maxRank - minRank);


            return string.Concat(BaseLinkClassName, normalizedRank);
        }

    }
}
