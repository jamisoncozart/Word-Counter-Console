|Behavior|Input|Output|
|:-:|:-:|:-:|
|If user input contains numbers, throw error and ask prompt again.|"cat1"|"Invalid input, please only use letters" **reprompt**|
|User inputs a word, store word in SeachWord property of RepeatCounter class.|"cat"|RepeatCounter.SearchWord => "cat"|
|User inputs a sentence after the word, store sentence in Sentence property of RepeatCounter class.|"This is my cat"|RepeatCounter.Sentence => "This is my cat"|
|If user inputs valid word and sentence, return number of instances of the word in the sentence.|"cat", "This is my cat"|"1 instance of 'cat' in 'This is my cat'."|
|WordCounter does not count instances of word within another word.|"cat", "This is my cathedral"|"0 instances of 'cat' in 'This is my cathedral'|
|WordCounter is agnostic to uppercase and lowercase letters|"cat", "This is my Cat"|"1 instance of 'cat' in 'This is my Cat'."|
|WordCounter is agnostic to punctuation|"cat", "This is my cat."|"1 instance of 'cat' in 'This is my cat.'."|