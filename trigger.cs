using System.Runtime.CompilerServices;
using Sandbox;

public sealed class Trigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{

 bool _iTouching; 
 



	protected override void OnStart()
    {
      _iTouching = false;

    }

    void ITriggerListener.OnTriggerEnter(Collider other)
    {
		

		_iTouching = true;
        Log.Info("In");
       GameManager.ActiveScene.Load(sceneFile);
      Sound.Play(soundEvent);

	   

         
    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {

		
	Log.Info("Out");
	
    

    }
	[Property] public SceneFile sceneFile {get; set;}
  [Property] public SoundEvent soundEvent {get; set;}
	//public Vector3( float x, float y, float z );
	//[Property] Vector3 vector { get; set; }
	//[Property] Rotation rotation {get; set;}
	


	
}
