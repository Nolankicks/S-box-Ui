using System.IO.Enumeration;
using Sandbox;

public sealed class music : Component
{
    
[Property] public SoundEvent MenuMusic { get; set; }
[Property] public bool PlayMenuMusic {get; set;}

    protected override void OnStart()
    {    
		if (PlayMenuMusic==true)
		{
			Sound.Play(MenuMusic);
			
		}



}

    }



