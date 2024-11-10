namespace Blazor.Models
{
    public class OnFavoriteChangedEventArgs : EventArgs
    {
        public Product Product { get; set; }
        public bool ToAdd { get; set; }
    }
}
