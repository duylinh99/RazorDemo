using System.Collections.Generic;

namespace RazorPagesMovie.Pages_Movies
{
    internal class SelectList
    {
        private List<string> list;

        public SelectList(List<string> list)
        {
            this.list = list;
        }
    }
}