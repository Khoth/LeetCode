using Newtonsoft.Json.Linq;
using Problem2;
using System.Text;

namespace UnitTests
{
    public class Problem2
    {
        [Theory]
        [InlineData("2,4,3", "5,6,4", "7,0,8")]
        [InlineData("0", "0", "0")]
        [InlineData("9,9,9,9,9,9,9", "9,9,9,9", "8,9,9,9,0,0,0,1")]
        public void AddTwoNumbers_Returns_ExpectedResult(string listNode1Str, string listNode2Str, string expectedResultNodeStr)
        {
            var solution = new Solution();
            var listNode1 = ListNodeFromString(listNode1Str);
            var listNode2 = ListNodeFromString(listNode2Str);

            var resultListNode = solution.AddTwoNumbers(listNode1, listNode2);

            var resultListNodeStr = ListNodeToString(resultListNode);
            resultListNodeStr.Should().BeEquivalentTo(expectedResultNodeStr);
        }

        private static ListNode ListNodeFromString(string input)
        {
            var resultListNode = new ListNode();
            var listNodeValues = input.Split(',');
            var currentListNode = resultListNode;

            for (int i = 0; i < listNodeValues.Length; i++)
            {
                currentListNode.val = int.Parse(listNodeValues[i]);

                if (i == listNodeValues.Length - 1)
                {
                    break;
                }

                var next = new ListNode();
                currentListNode.next = next;
                currentListNode = next;
            }

            return resultListNode;
        }

        private static string ListNodeToString(ListNode listNode)
        {
            var result = new StringBuilder();
            var currentListNode = listNode;

            while (currentListNode != null)
            {
                result.Append(currentListNode.val);
                currentListNode = currentListNode.next;
                
                if (currentListNode != null)
                {
                    result.Append(',');
                }
            }

            return result.ToString();
        }
    }
}
