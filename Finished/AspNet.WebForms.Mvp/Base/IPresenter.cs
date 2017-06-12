namespace AspNet.WebForms.Mvp.Base
{
    public interface IPresenter<T> where T : IView
    {
        void SetView(T view);
        void Initialize();
    }
}
