Select quote, a.Author, atype.AnswerTypeChoice
from Questions q
left join Answers a on q.Question_Id = a.Question_Id 
left join AnswerTypes atype on a.AnswerType_Id = atype.AnswerType_Id