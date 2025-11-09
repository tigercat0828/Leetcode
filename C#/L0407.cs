public class Solution {
    private readonly int[] dx = [1,-1,0,0];
    private readonly int[] dy = [0,0,1,-1];

    public int TrapRainWater(int[][] heightMap) {

        int rows = heightMap.Length;
        int cols = heightMap[0].Length;

        bool[,] visited = new bool[rows,cols];
        PriorityQueue<(int,int,int), int> queue = new();    // (r,c,h)
        // add the boundary into the queue
        for(int r =0;r<rows;r++){
            queue.Enqueue((r,0,heightMap[r][0]), heightMap[r][0]);
            queue.Enqueue((r,cols-1,heightMap[r][cols-1]), heightMap[r][cols-1]);
            visited[r,0] = true;
            visited[r,cols-1] = true;
        }
        for(int c=0;c<cols;c++){
            queue.Enqueue((0,c,heightMap[0][c]), heightMap[0][c]);
            queue.Enqueue((rows-1,c,heightMap[rows-1][c]), heightMap[rows-1][c]);
            visited[0,c] = true;
            visited[rows-1,c] = true;
        }
        int trappedWater =0;
        while(queue.Count > 0) {
            var (r,c,h) = queue.Dequeue();
            for(int i =0;i<4;i++){
                int nr = r+dx[i];
                int nc = c+dy[i];
                if(nr<0||nc<0||nr>=rows||nc>=cols||visited[nr,nc]) continue;

                visited[nr,nc] = true;

                if(heightMap[nr][nc] < h) {
                    trappedWater += h - heightMap[nr][nc];
                }
                int nh =  Math.Max(heightMap[nr][nc],h);
                queue.Enqueue((nr,nc,nh), nh);
            }
        }
        return trappedWater;
    }
}