using DANDERI.Collection.Design.HTML.Components.Components;
using System.Text;


namespace DANDERI.Collection.Design.HTML.Components.Designer
{
	public class HtmlDesigner
	{
		public static string GetBtnEmail(EmailRequestDesign Email)
		{
			StringBuilder EmailBuilder = new StringBuilder();
			
            EmailBuilder.Append($@"<!DOCTYPE html>
                <html>
                <head>
                  <style>
                    body {{font - family: Arial, sans-serif;
                      background-color: #f9f9f9;
                      margin: 0;
                      padding: 20px;
                    }}
                    .container {{max - width: 600px;
                      margin: 0 auto;
                      background-color: #fff;
                      padding: 20px;
                      border-radius: 8px;
                      box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
                    }}
                    h1 {{color: #333;
                      text-align: center;
                      margin-top: 0;
                    }}
                    .button {{display: inline-block;
                      background-color: #3c8dbc;
                      color: #fff;
                      text-decoration: none;
                      padding: 10px 20px;
                      border-radius: 4px;
                      margin-top: 20px;
                    }}
    
                    .container a.button {{display: block; 
                      margin: 0 auto;
                      text-align: center;
                      width: 150px; 
                    }}
                  </style>
                </head>
               <body>
      <div class=""container"">");
			EmailBuilder.Append(Email.H1Title != null ? $"<h1>{Email.H1Title}</h1>" : "");
			EmailBuilder.Append(Email.PBody != null ? $" <p>{Email.PBody}</p>" : "");




			return EmailBuilder.ToString();
		}
	}
}
