
Loose_Coupling_InDependency.MailSender sender = new();
sender.Send(new Loose_Coupling_InDependency.Gmail());
sender.Send(new Loose_Coupling_InDependency.Hotmail());

//-------

// Bad version:

Loose_Coupling_Dependency.MailSender sender2 = new();
sender2.Send();
sender2.Send();