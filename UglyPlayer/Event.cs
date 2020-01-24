using IrrKlang;

namespace UglyPlayer
{
    public class Event : ISoundStopEventReceiver
    {
        private readonly MainForm _form;

        public Event(MainForm form)
        {
            this._form = form;
        }

        public void OnSoundStopped(ISound sound, StopEventCause reason, object userData)
        {
            _form.HandleStop(reason);
        }
    }
}
