//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:N.N.NNNNN.N
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestOutput {
using System;

public class Helpers {
#line hidden
#line 1 "Helpers.cshtml"
public Template Bold(string s) {
#line default
#line hidden
return new Template(__razor_helper_writer => {

#line 1 "Helpers.cshtml"
                        
    s = s.ToUpper();


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <strong>");


#line 3 "Helpers.cshtml"
WriteTo(__razor_helper_writer, s);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</strong>\r\n");


#line 4 "Helpers.cshtml"


#line default
#line hidden
});

#line 4 "Helpers.cshtml"
}
#line default
#line hidden

#line 6 "Helpers.cshtml"
public Template Italic(string s) {
#line default
#line hidden
return new Template(__razor_helper_writer => {

#line 6 "Helpers.cshtml"
                          
    s = s.ToUpper();


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <em>");


#line 8 "Helpers.cshtml"
WriteTo(__razor_helper_writer, s);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</em>\r\n");


#line 9 "Helpers.cshtml"


#line default
#line hidden
});

#line 9 "Helpers.cshtml"
}
#line default
#line hidden

public Helpers() {
}
public override void Execute() {
WriteLiteral("\r\n");

WriteLiteral("\r\n");


#line 11 "Helpers.cshtml"
Write(Bold("Hello"));


#line default
#line hidden
}
}
}
