
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace VSMacStringResourceTestAddin
{
	class StartupHandler : CommandHandler
	{
		protected override void Run ()
		{
			string text = Resources.TestString;
			MessageService.ShowMessage ("Test resource string", text);
		}
	}
}

