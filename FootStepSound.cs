using Sandbox;
//Code courtesy of DrakeFruit
public sealed class FootStepSound : Component
{
	[Property] SkinnedModelRenderer Source { get; set; }
	[Property] float Volume { get; set; } = 2f;

	protected override void OnEnabled()
	{
		if ( Source is null )
			return;

		Source.OnFootstepEvent += OnEvent;
	}

	protected override void OnDisabled()
	{
		if ( Source is null )
			return;

		Source.OnFootstepEvent -= OnEvent;
	}

	private void OnEvent( SceneModel.FootstepEvent e )
	{
		var tr = Scene.Trace
			.Ray( e.Transform.Position + Vector3.Up * 20, e.Transform.Position + Vector3.Up * -20 )
			.Run();

		if ( !tr.Hit )
			return;

		var angles = e.Transform.Rotation.Angles();
		angles.pitch = 0;
		angles.roll = 0;
	

		var sound = e.FootId == 0 ? tr.Surface.Sounds.FootLeft : tr.Surface.Sounds.FootRight;

		SoundHandle footstepSound = Sound.Play( sound, Transform.Position );
		footstepSound.Volume = Volume;
	}
}
