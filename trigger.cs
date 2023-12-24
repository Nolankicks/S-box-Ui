using Sandbox;

public sealed class Trigger : Component, Component.ITriggerListener
{

 bool _iTouching; 
  
    protected override void OnStart()
    {
      _iTouching = false;
    }

    void ITriggerListener.OnTriggerEnter( Collider other ) 
    {
        _iTouching = true;
        Log.Info("In");
       
        
    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {
        _iTouching = false;
        Log.Info("Out");
		GameManager.ActiveScene.LoadFromFile("scenes/platformer.scene");

        
    }

}
