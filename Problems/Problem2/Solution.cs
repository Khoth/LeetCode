namespace Problem2
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var resultListNode = new ListNode();
            var listNode1CurrentDigit = l1;
            var listNode2CurrentDigit = l2;
            var nextDecAdd = 0;
            ListNode currentListNode = resultListNode;
            bool hasNextListNode;

            do
            {
                var currentSum = (listNode1CurrentDigit?.val ?? 0) + (listNode2CurrentDigit?.val ?? 0) + nextDecAdd;
                var currentValue = currentSum % 10;

                currentListNode.val = currentValue;
                nextDecAdd = currentSum / 10;
                listNode1CurrentDigit = listNode1CurrentDigit?.next;
                listNode2CurrentDigit = listNode2CurrentDigit?.next;
                hasNextListNode = listNode1CurrentDigit != null || listNode2CurrentDigit != null || nextDecAdd > 0;

                if (hasNextListNode)
                {
                    currentListNode.next = new ListNode();
                    currentListNode = currentListNode.next;
                }
            }
            while (hasNextListNode);

            return resultListNode;
        }
    }
}