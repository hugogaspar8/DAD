using System;
// este delegate e' a base para o event Move do slider
delegate void MoveEventHandler(object source, MoveEventArgs e);

// esta  classe contem os argumentos do evento move do slider
public class MoveEventArgs : EventArgs {
	public int newPosition;
    public bool cancel;
    public MoveEventArgs(int newPosition)
    {
        this.newPosition = newPosition;
    }
}


class Slider {
	private int position;
    public event MoveEventArgs Move;

	public int Position {
		get {
			return position;
		}
	// e' este bloco que e' executado quando se move o slider
		set {
            if(position != value){
                if(Move != null)
                {
                    MoveEventArgs args = new MoveEventArgs(value);
                    Move(this, args);
                    if (args.cancel)
                        return;
                }
                position = value;
            }
		}
	}
}


class Form {
	static void Main( ) {
		Slider slider = new Slider( );

        // TODO: register with the Move event
        slider.Move += new MoveEventHandler(slider_Move);
        // estas sao as duas alteracoes simuladas no slider
        slider.Position = 20;
		slider.Position = 60;
        Console.ReadLine();
    }

	// este é o método que deve ser chamado quando o slider e' movido
	static void slider_Move(object source, MoveEventArgs e) {
        if (e.newPosition < 50)
            Console.WriteLine("OK");
        else
        {
            e.cancel = true;
            Console.WriteLine("Can't go that high!");
        }
    }
}
