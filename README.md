# _Word Checker_

#### _A C# application that allows users to check how many times a word appears in a phrase, 12/2/2016_

#### By _**James R. Howard**_

## Description

_This application has two input fields, One asks for user to input a word to check in a sentence; the other asks for the user to input a sentence. When both fields are filled out and the user submits the form it directs to the View results.cshtml. There the application passes how many time a word appears in the inputted sentence._

## Specs


| Behavior - Plain English                                        | Input                                    | Output                                   |
|-----------------------------------------------------------------|------------------------------------------|------------------------------------------|
| User inputs sentence "I like my dog"                            | I like my dog                            | I like my dog                            |
| User inputs word to check on sentence                           | dog                                      | 1                                        |
| User inputs sentence "I like my dog"                            | Iike my dog                              | I like my dog                            |
| User inputs word to check on sentence                           | cat                                      | 0                                        |
| User inputs sentence "I like my dOg"                            | I like my dOg                            | I like my dOg                            |
| User inputs word to check on sentence                           | dog                                      | 1                                        |
| User inputs sentence "My dog loves to play with my friends dog" | My dog loves to play with my friends dog | My dog loves to play with my friends dog |
| User inputs word to check on sentence                           | dog                                      | 2                                        |
| User inputs sentence "I love my Dog!"                           | I love my Dog                            | I love my dog                            |
| User inputs Word to check in sentence                           | Dog!                                     | 1                                        |
| User inputs sentence "I love my Dog"                            | User inputs sentence "I love my Dog"     | User inputs sentence "I love my Dog"     |
| User inputs word to check in sentence                           | cat                                      | cat                                      |

## Setup/Installation Requirements

## Setup/Installation Requirements

* _Windows OS_
* _Clone file from GitHub.com_
* _Open Windows PowerShell_
* _Use command >dnu restore_
* _Use command >dnx kestrel_
* _Open up a chrome browser_
* _Go to http://localhost:5004_

## Known Bugs

_There are no known issues or bugs at this point in time._

## Support and contact details

_if you run into any issues or have any concerns or ideas please contact me at jrh682@gmail.com_

## Technologies Used

_This application uses_
* _HTML_
* _C#_
* _"Microsoft.AspNet.Server.Kestrel": "1.0.0-*"_
* _"Microsoft.AspNet.Owin": "1.0.0-*"_
* _"Nancy": "1.3.0"_
* _"Nancy.ViewEngines.Razor": "1.3.0_
* _"xunit": "2.1.0"_
* _"xunit.runner.dnx": "2.1.0-rc1-*"_

### License

*The MIT License (MIT)
Copyright (c) <2016> <James R. Howard>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*

Copyright (c) 2016 **_James R. Howard Student at EPICODUS_**
