namespace IsbmClient
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class NotificationService : INotificationService
    {
        
        public virtual NotifyListenerResponse NotifyListener(NotifyListenerRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual System.IAsyncResult BeginNotifyListener(NotifyListenerRequest request, System.AsyncCallback callback, object asyncState)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual NotifyListenerResponse EndNotifyListener(System.IAsyncResult result)
        {
            throw new System.NotImplementedException();
        }
    }
}
