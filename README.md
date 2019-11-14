# PalindromeProblem
The repository is created for purposes of demostrate simplicity of linq method
This method will be demonstrated in application of solving classic programming palindrome problem.
As for the problem in details, it is answer the question whether string is palindrome. Accoding to https://en.wikipedia.org/wiki/Palindrome palinrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward\
Palindrome samples: "abbba", "Nan", "SaaS"\
But there more complex samples: "mam is not'ton! Si Mam?" \

The algorithm for this problem is compare the first left (if exist) significant letter with the first right (if exist) significant letter, then the second left significant letter with the second right significant letter, and so on before "left" and "right" doesn't reach the "middle".\

The desicion is work with moving of leftIndex and rightIndex in "while" loop with "while"-loops inside to find next significant letters.\ 
You can see code of this implementaion in extension method IsPalindrome(this string input)









This desicion has taken about forty minutes. I think too long time for this simple problem.

