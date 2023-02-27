// See https://aka.ms/new-console-template for more information


using Session_07;
using System;
using System.Data.Common;
using System.Linq.Expressions;

Console.WriteLine("Type string with one or more words or a Decimal:");

string input = Console.ReadLine();

ActionRequest request = null;

ActionResolver actionResolver = new ActionResolver();

ActionResponse response = new ActionResponse();

Console.WriteLine("\nType:");
Console.WriteLine("`1` to convert to Binary");
Console.WriteLine("`2` to convert the longest word to uppercase");
Console.WriteLine("`3` to reverse a string");

string? inputAction = Console.ReadLine();
ActionEnum action;


try {
    switch (inputAction) {
        case "1":
            action = ActionEnum.Convert;
            request = new ActionConvert(input, action);
            break;
        case "2":
            action = ActionEnum.Uppercase;
            request = new ActionUppercase(input, action);
            break;
        case "3":
            action = ActionEnum.Reverse;
            request = new ActionReverse(input, action);
            break;
        default:
            actionResolver.Logger.Write(new Message("Not right entry!"));
            break;
    }

    if (request != null) {


        response = actionResolver.Execute(request);


    } else {
        actionResolver.Logger.Write(new Message("Closing..."));
    }
}
catch (Exception ex) {

    actionResolver.Logger.Write(new Message(ex.Message));
}
finally {
    actionResolver.Logger.ReadAll();
}


Console.ReadLine();