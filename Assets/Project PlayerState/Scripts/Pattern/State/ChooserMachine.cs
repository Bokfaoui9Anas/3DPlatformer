

public class ChooserMachine
{
  private IChooser _currentstate;
  public P1 _P1;
  public P2 _P2;
  public P3 _P3;
  
  public ChooserMachine(ChooserController chooserController)
  {
    _P1 = new P1(chooserController);
    _P2 = new P2(chooserController);
    _P3 = new P3(chooserController);
  }

  public void Initialisation(IChooser state)
  {
    
    _currentstate = state;
    state.Enter();
  }
  public void ChangeState(IChooser NewState)
  {
    _currentstate.Exit();
    _currentstate = NewState;
    NewState.Enter();
  }  
  public  void Update()
  {
    _currentstate?.Update();
  }
  
}