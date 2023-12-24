using Sandbox;

public sealed class Trigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
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
		GameManager.ActiveScene.Load(scene);

        
    }
	[Property] public SceneFile scene { get; set; }
}
