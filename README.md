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
