using System.Runtime.CompilerServices;
using Sandbox;



public sealed class SpawnTrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{

 int iTouching; 



	

    
    void ITriggerListener.OnTriggerEnter( Collider other ) 
    {
        iTouching++;

	
			        Log.Info("In");
       SceneUtility.Instantiate(prefabScene, vector, rotation );
		
		
		




    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {
        iTouching--;
        Log.Info("Out");
		
	
	
    

    }

	
	[Property] public PrefabScene prefabScene {get; set;}
	//public Vector3( float x, float y, float z );
	[Property] Vector3 vector { get; set; }
	[Property] Rotation rotation {get; set;}
	


	
}
