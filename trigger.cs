using Sandbox;

public sealed class trigger : Component, Component.ITriggerListener
{

void changeScene() //change scene void to load the newScene defined above
	{
		Log.Info("aaa");
		GameManager.ActiveScene.Load(newScene);
	}	
[Property] public SceneFile newScene { get; set; }
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
		GameManager.ActiveScene.Load(newScene);

        
    }

}
