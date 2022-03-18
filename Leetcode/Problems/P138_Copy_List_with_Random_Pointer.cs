using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P138_Copy_List_with_Random_Pointer {
        public class Node {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val) {
                val = _val;
                next = null;
                random = null;
            }
        }
        public Node CopyRandomList(Node head) {
            if(head == null) return null;
            Dictionary<Node, Node> map = new();

            // copy node in list
            Node current = head;
            while (current != null) { 
                map.Add(current, new Node(current.val));
                current = current.next;
            }
            // connect nodes' next and random
            current = head;
            while (current != null) {
                if(current.next != null) {
                    map[current].next = map[current.next];
                }
                if(current.random != null) {
                    map[current].random = map[current.random];
                }
                current = current.next;
            }
            return map[head];
        }
    }
}
