namespace IsbmClient
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class ISBMNotificationService : IISBMNotificationService
    {
        
        public virtual NotifyListenerResponse NotifyListener(NotifyListenerRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
