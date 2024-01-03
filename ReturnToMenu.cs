using Sandbox;

public sealed class ReturnToMenu : Component
{
	[Property] public SoundEvent soundEvent {get; set;}
	protected override void OnUpdate()
	{
		if ( Input.EscapePressed )
		{
			GameManager.ActiveScene.LoadFromFile( "scenes/menu.scene" );
			Sound.Play(soundEvent);
		}
	}
}
