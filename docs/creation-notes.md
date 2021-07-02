# Identity Server

The base for the identity server is [Skoruba.IdentityServer4.Admin](https://github.com/skoruba/IdentityServer4.Admin).

The initial project was created using the templates provided;

```bash
dotnet new -i Skoruba.IdentityServer4.Admin.Templates::2.0.1
```

And created with;

```bash
dotnet new skoruba.is4admin --name "Contender.Tally.Identity" --title "Contender Tally" --adminemail "admin@example.com" --adminpassword "letmein123!" --adminrole "admin" --adminclientid "contentery-tally-admin-client" --adminclientsecret "e3aecd78-b5f9-4bd0-bc95-d6f877f1c4f0" --dockersupport true
```
