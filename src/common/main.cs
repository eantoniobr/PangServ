/***********************************************
 *
 *   PangServ - Pangya Server Emulator       
 *   Copyright � 2016 PangServ-Team
 *
 ***********************************************
 * Common code.
 ***********************************************/
using showmsg; // class console.
using Logging;

namespace CommonMain
{
    class CMain
    {
        static void Main()
        {
            cLogging commonlog = new cLogging("common.log");
            commonlog.write("Common Service started.");
            console.message("===============================================");
            console.message("||                                           ||");
            console.message("||   PangServ - Pangya Server Emulator       ||");
            console.message("||   Copyright <c> 2016 PangServ-Team        ||");
            console.message("||                                           ||");
            console.message("===============================================");
            commonlog.write("Common Service stopped.");
        }  
    }
}
