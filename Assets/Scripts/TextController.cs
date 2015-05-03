using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;

    States _state;

    // Use this for initialization
    void Start()
    {
        _state = States.cell;
        text.text = "Hello world";
    }

    // Update is called once per frame
    void Update()
    {
        print(_state);
        if (_state == States.cell)
            StateCell();
        else if (_state == States.cell_mirror)
            StateCellMirror();
        else if (_state == States.sheets_0)
            StateSheets0();
        else if (_state == States.sheets_1)
            StateSheets1();
        else if (_state == States.lock_0)
            StateLock0();
        else if (_state == States.lock_1)
            StateLock1();
        else if (_state == States.mirror)
            StateMirror();
        else if (_state == States.freedom)
            StateFreedmon();
    }

    void StateCell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside.\n\n" +
                    "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
            _state = States.sheets_0;
        else if (Input.GetKeyDown(KeyCode.M))
            _state = States.mirror;
        else if (Input.GetKeyDown(KeyCode.L))
            _state = States.lock_0;
    }

    void StateMirror()
    {
        text.text = "The dirty old mirror on the wall seems loose.\n\n" +
                    "Press T to Take the mirror, or R to Return to cell";
        if (Input.GetKeyDown(KeyCode.T))
        {
            _state = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _state = States.cell;
        }
    }

    void StateSheets0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
                    "time somebody changed them. The pleasures of prison life " +
                    "I guess!\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            _state = States.cell;
        }
    }

    void StateSheets1()
    {
        text.text = "Holding a mirror in your hand doesn't make the sheets look " +
                    "any better.\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            _state = States.cell_mirror;
        }
    }

    void StateLock0()
    {
        text.text = "This is one of those button locks. You have no idea what the " +
                    "combination is. You wish you could somehow see where the dirty " +
                    "fingerprints were, maybe that would help.\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            _state = States.cell;
        }
    }

    void StateLock1()
    {
        text.text = "You carefully put the mirror through the bars, and turn it round " +
                    "so you can see the lock. You can just make out fingerprints around " +
                    "the buttons. You press the dirty buttons, and hear a click.\n\n" +
                    "Press O to Open, or R to Return to your cell";
        if (Input.GetKeyDown(KeyCode.O))
        {
            _state = States.freedom;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _state = States.cell_mirror;
        }
    }

    void StateCellMirror()
    {
        text.text = "You are still in your cell, and you STILL want to escape! There are " +
                    "some dirty sheets on the bed, a mark where the mirror was, " +
                    "and that pesky door is still there, and firmly locked!\n\n" +
                    "Press S to view Sheets, or L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            _state = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            _state = States.lock_1;
        }
    }

    void StateFreedmon()
    {
        text.text = "You are FREE!\n\n" +
                    "Press P to Play again";
        if (Input.GetKeyDown(KeyCode.P))
        {
            _state = States.cell;
        }
    }
}