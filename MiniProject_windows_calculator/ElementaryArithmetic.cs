namespace MiniProject_windows_calculator
{
    struct ElementaryArithmeticStruct
    {
        // 이전에 다른 연산자를 사용한 상태에서 새 연산자 입력시 이전 식 자동 계산
        static public string PastAssignment(string expression, string new_operand)
        {
            // 기존 식(좌항 연산자) 분리
            if (expression.Length > 0) // 기존 식이 존재할 때
            {
                string[] expression_terms = expression.Split(' ');

                // 좌항 피연산자
                double left_operand = double.Parse(expression_terms[0]);
                // 연산자
                string past_operator = expression_terms[1];
                // 우항 피연산자
                double right_operand = double.Parse(new_operand);

                // 연산 결과
                double result = 0.0;
                switch (past_operator)
                {
                    case "÷":
                        if (right_operand == 0)
                            return "0으로 나눌 수 없습니다.";
                        result = left_operand / right_operand;
                        break;
                    case "×":
                        result = left_operand * right_operand;
                        break;
                    case "−":
                        result = left_operand - right_operand;
                        break;
                    case "+":
                        result = left_operand + right_operand;
                        break;
                }
                return result.ToString();
            }
            else // 기존 식이 전무하면 새로 입력된 피연산자만 반환
            {
                return new_operand;
            }
        }

        static public string Arithmetic(string expression, string new_operand, char past_operator, string new_operator)
        {
            if (past_operator == '=') // 이전에 이미 계산을 완료한 경우
            {
                return (new_operand + new_operator); // 수식에 추가할 항 반환
            }
            else // 이전에 다른 연산자들을 사용한 경우
            {
                return PastAssignment(expression, new_operand) + new_operator;
            }
        }
    }

    internal class ElementaryArithmetic
    {
        string new_operator;

        public ElementaryArithmetic(char new_operator)
        {
            this.new_operator = string.Format($" {new_operator} ");
        }

        // 사칙연산 버튼 입력 통일
        public string Arithmetic(string expression, string new_operand, char past_operator) =>
            ElementaryArithmeticStruct.Arithmetic(expression, new_operand, past_operator, new_operator);

        // = 버튼
        public string Assignment(string expression, string new_operand, char past_operator)
        {
            if (past_operator == '_')
            {
                past_operator = '=';
                return ElementaryArithmeticStruct.PastAssignment("", new_operand);
            }
            else
            {
                past_operator = '=';
                return ElementaryArithmeticStruct.PastAssignment(expression, new_operand);
            }
        }
    }
}
