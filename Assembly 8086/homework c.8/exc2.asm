.MODEL small
.STACK 100h
.DATA
    ;var1 db 9d
    var1 db 7d
    var2 db 7d
.CODE
    mov ax, @data
    mov ds, ax
    
    mov ax, 0
    
    mov bl, var1
    mov cl, var2
    cmp bl, cl
    je are_equal
    jne are_not_equal
    jmp exit
    
are_equal:
    mov al, var1
    add al, var2
    jmp exit

are_not_equal:
    mov al, var1
    sub al, var2
    jmp exit
    
exit:
    mov ah, 4Ch
    int 21h    
          
END